using Pecas;
class Rainha : Peca{
    public Rainha(EnumCor cor, int x, int y, string img) : base(cor, x, y, img){
       
    }
       
    public override bool validarMovimento(int destinoX, int destinoY)
    {
        // Calcula a diferença entre as posições
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);


        // A Rainha pode se mover quantas casas quiser em qualquer direção
        return difX <= 8 && difY <= 8;
    }
}
