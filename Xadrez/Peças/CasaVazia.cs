using Pecas;
public class CasaVazia : Peca{
    public  CasaVazia(EnumCor cor, int x, int y, string img) : base(cor, x, y, img){
       
    }
    public override bool validarMovimento(int destinoX, int destinoY){
        return true;
    }


}
