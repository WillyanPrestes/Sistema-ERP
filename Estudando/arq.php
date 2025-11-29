<?php

class oConexao
{
    private $conn;
    private $str = "localhost";
    private $user = "root";
    private $pass = "32962377";
    private $db = "estudo";

    private function Abrir()
    {
        $this->conn = new mysqli($this->str, $this->user, $this->pass, $this->db);

        if ($this->conn->connect_error) {
            die("Erro de conexão: " . $this->conn->connect_error);
        }

        $this->conn->set_charset("utf8");
    }

    // ---------------------------------------------------------
    //  INSERIR (com transação)
    // ---------------------------------------------------------
    public function inserir($pr)
    {
        $this->Abrir();
        $this->conn->begin_transaction();

        try {
            $sql = "INSERT INTO produto(descricao, preco, estoque) VALUES (?, ?, ?)";
            $stmt = $this->conn->prepare($sql);
            $stmt->bind_param("sdi", $pr->Descricao, $pr->Preco, $pr->Estoque);

            $stmt->execute();

            $this->conn->commit();
            $stmt->close();
            $this->conn->close();
            return true;

        } catch (Exception $e) {
            $this->conn->rollback();
            $this->conn->close();
            return false;
        }
    }

    // ---------------------------------------------------------
    // EXCLUIR
    // ---------------------------------------------------------
    public function Excluir($sql)
    {
        $this->Abrir();
        $res = $this->conn->query($sql);
        $this->conn->close();

        if ($res === TRUE)
            return true;
        else
            return false;
    }

    // ---------------------------------------------------------
    // LISTAR DataTable (Array associativo)
    // ---------------------------------------------------------
    public function ListarDT($sql = "SELECT * FROM produtos")
    {
        $this->Abrir();
        $result = $this->conn->query($sql);

        $lista = [];

        while ($row = $result->fetch_assoc()) {
            $lista[] = $row;
        }

        $this->conn->close();
        return $lista;
    }

    // ---------------------------------------------------------
    // LISTAR objetos oProduto
    // ---------------------------------------------------------
    public function Listar()
    {
        $dt = $this->ListarDT();
        $lst = [];

        foreach ($dt as $dr) {
            $produto = new oProduto();
            $produto->Id = intval($dr["id"]);
            $produto->Descricao = $dr["descricao"];
            $produto->Estoque = intval($dr["estoque"]);
            $produto->Preco = floatval($dr["preco"]);

            $lst[] = $produto; // você esqueceu de adicionar na lista no C#
        }

        return $lst;
    }

    // ---------------------------------------------------------
    // BUSCAR POR DESCRIÇÃO
    // ---------------------------------------------------------
    public function Buscar($desc)
    {
        $this->Abrir();

        $sql = "SELECT * FROM produtos WHERE descricao LIKE ?";
        $stmt = $this->conn->prepare($sql);

        $like = "%" . $desc . "%";
        $stmt->bind_param("s", $like);
        $stmt->execute();
        $res = $stmt->get_result();

        $produto = null;

        while ($row = $res->fetch_assoc()) {
            $produto = new oProduto();
            $produto->Id = intval($row["id"]);
            $produto->Descricao = $row["descricao"];
            $produto->Estoque = intval($row["estoque"]);
            $produto->Preco = floatval($row["preco"]);
        }

        $stmt->close();
        $this->conn->close();
        return $produto;
    }
}
?>
