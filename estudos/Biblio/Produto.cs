namespace estudos {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quant {get; private set;}

//Formas diferentes de iniciar um produto
        public Produto(){
            Quant = 1;
        }
        public Produto(string nome, double preco):this() {
            _nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade):this(nome, preco) {
            Quant = quantidade;
        }

//Metodos GET and SET como propriedades
        public string Nome{
            get{return _nome;}
            set{
                if(value != null && value.Length > 1){
                _nome = value;
            }
            }
        }
        
//Metodos criados 
        public double ValorTotalEmEstoque() {
            return Preco * Quant;
        }
        public void AdicionarProdutos(int quantidade) {
            Quant += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quant -= quantidade;
        }

//Criação do substitução da chamada do objeto
        public override string ToString() {
            return _nome + ", $ " + Preco.ToString("F2") + ", " + Quant + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}