using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models.Objetos.Base
{
    public class _Validacao : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, object> _valores = new();
        private readonly Dictionary<string, List<string>> _erros = new();

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        protected T GetValor<T>(string propriedade)
        {
            if (_valores.TryGetValue(propriedade, out var valor))
                return (T)valor;
            return default;
        }

        protected void SetValor<T>(T valor, string propriedade)
        {
            if (EqualityComparer<T>.Default.Equals(GetValor<T>(propriedade), valor))
                return;

            _valores[propriedade] = valor;
            OnPropertyChanged(propriedade);
            ValidateProperty(valor, propriedade);
        }

        protected void OnPropertyChanged(string propriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propriedade));
        }

        private void ValidateProperty(object valor, string propriedade)
        {
            var contexto = new ValidationContext(this) { MemberName = propriedade };
            var resultados = new List<ValidationResult>();

            _erros.Remove(propriedade);

            bool valido = Validator.TryValidateProperty(valor, contexto, resultados);
            if (!valido)
                _erros[propriedade] = resultados.Select(r => r.ErrorMessage).ToList();

            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propriedade));
        }

        public bool HasErrors => _erros.Any(kv => kv.Value?.Count > 0);

        public IEnumerable GetErrors(string propriedade)
        {
            if (string.IsNullOrEmpty(propriedade))
                return _erros.SelectMany(kv => kv.Value);

            return _erros.ContainsKey(propriedade)
                ? _erros[propriedade]
                : Enumerable.Empty<string>();
        }
    }
}