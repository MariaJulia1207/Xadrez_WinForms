using Pecas;
class Torre : Peca{
    public Torre(EnumCor cor, int x, int y, string img) : base(cor, x, y, img){
       
    }
       
    public override bool validarMovimento(int destinoX, int destinoY)
    {
        // Calcula a diferença entre as posições
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);


        // A Torre pode se mover quantas casas quiser na horizontal ou vertical
        return difX <= 1 && difY <= 1;
    }
}
