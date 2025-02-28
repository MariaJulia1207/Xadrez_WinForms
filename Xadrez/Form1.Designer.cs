namespace Xadrez_Winforms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    Button botaoClicado;
    int _x=-1, _y=-1;
    private System.ComponentModel.IContainer components = null;
    private const int TamanhoDaMatriz = 8;
    private Button[,] matriz = new Button[TamanhoDaMatriz, TamanhoDaMatriz];
    private Random aleatorio = new Random();
    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }




    #region Windows Form Designer generated code




    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(850, 850);
        this.Text = "Xadrez";


        for(int i = 2; i < 6 ;i++){
            for(int j = 0; j<8 ;j++){
                int x = j, y = i;
                 tabuleiro[x,y] = new CasaVazia(0, x*50, y*50,"casaVazia.png");
                 this.Controls.Add(tabuleiro[x,y].pictureBox);
                 tabuleiro[x,y].pictureBox.BringToFront();
                 tabuleiro[x,y].pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(tabuleiro[x,y]); };
            }  
        }
        Rei reiBranco = new Rei(EnumCor.Branca,100,150,"reiBranco.png");
        tabuleiro[reiBranco.x,reiBranco.y] = reiBranco;
        this.Controls.Add(reiBranco.pictureBox);
        reiBranco.pictureBox.BringToFront();
        reiBranco.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiBranco); };


        Rei reiPreto = new Rei(EnumCor.Preta,100,100,"reiPreto.png");
        tabuleiro[reiPreto.x,reiPreto.y] = reiPreto;
        this.Controls.Add(reiPreto.pictureBox);
        reiPreto.pictureBox.BringToFront();
        reiPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiPreto); };
        /*for(int linha = 0; linha < TamanhoDaMatriz; linha++)
        {
            for(int coluna = 0; coluna < TamanhoDaMatriz; coluna++)
            {
                Button botao = new Button();
                botao.Size = new Size(50,50);
                botao.Location = new Point(50*linha,50*coluna);
                int x = linha;
                int y = coluna;
                botao.Click += (sender, args) => {OnCellClick(x,y);};
                matriz[linha,coluna] = botao;
                this.Controls.Add(botao);
            }
        }*/
/*
        Bispo bispo = new Bispo(EnumCor.Preta,1,1);
        Rainha rainha = new Rainha(EnumCor.Preta,1,1);
        Cavalo cavalo = new Cavalo(EnumCor.Preta,1,1);
        Torre torre = new Torre(EnumCor.Preta,1,1);
        Peao peaoP = new Peao(EnumCor.Preta,1,1);
        Peao peaoB = new Peao(EnumCor.Preta,1,1);
        Rei rei = new Rei(EnumCor.Branca,1,1);
        Controls.Add(rainha.rainha);
        Controls.Add(bispo.bispo);
        Controls.Add(cavalo.cavalo);
        Controls.Add(torre.torre);
        Controls.Add(rei.rei);
        Controls.Add(peaoP.peao);
        Controls.Add(peaoB.peao);*/
       
    }




    #endregion
}
