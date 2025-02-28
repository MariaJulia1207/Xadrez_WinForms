using Pecas;
class Bispo : Peca{
    public Bispo(EnumCor cor, int x, int y, string img) : base(cor, x, y, img){
       
    }
    public override bool validarMovimento(int destinoX, int destinoY)
    {
        // Calcula a diferença entre as posições
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);


        // O Bispo pode se mover quantas casas quiser em uma diagonal
        return difX <= 1 && difY <= 1;
    }
}
