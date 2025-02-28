using Pecas;
class Peao : Peca{
    public Peao(EnumCor cor, int x, int y, string img) : base(cor, x, y, img){
       
    }
    public override bool validarMovimento(int destinoX, int destinoY)
    {
        // Calcula a diferença entre as posições
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);


        // O Peão pode se mover apenas uma casa na vertical, para frente; ou caso haja uma peça de outra cor na diagonal, o Peão pode comê-la; ao chegar ao final do Tabuleiro, o Peão vira Rainha
        return difX <= 1 && difY <= 1;
    }
}
