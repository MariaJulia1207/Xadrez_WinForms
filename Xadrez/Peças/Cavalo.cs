using Pecas;
class Cavalo : Peca{
    public Cavalo(EnumCor cor, int x, int y, string img) : base(cor, x, y, img){
       
    }
    public override bool validarMovimento(int destinoX, int destinoY)
    {
        // Calcula a diferença entre as posições
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);


        // O Cavalo pode se mover em uma direção em formato de "L"; é a única peça que pode pular por sobre outras peças
        return difX <= 1 && difY <= 1;
    }
}
