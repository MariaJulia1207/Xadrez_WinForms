using Pecas;


namespace Xadrez_Winforms;




public partial class Form1 : Form
{
    public static int sizeOfTabuleiro = 8;
   
    private PictureBox pecaSelecionada = null; // Armazena a peça selecionada
    private int origemX = -1, origemY = -1; // Armazena a posição da peça
    public Peca[,] tabuleiro = new Peca[sizeOfTabuleiro,sizeOfTabuleiro];
    public Form1()
    {
        InitializeComponent();
    }
    private void cliqueNoTabuleiro(Peca peca)
{
    if (origemX == -1 && origemY == -1) // Primeiro clique: seleciona a peça
    {
        if (peca is not CasaVazia){
            pecaSelecionada = peca.pictureBox;
            origemX = peca.x;
            origemY = peca.y;
            MessageBox.Show($"Peça selecionada em ({peca.x}, {peca.y})");
        }
    }
    else // Segundo clique: tenta mover a peça
    {
        Peca pecaOrigem = tabuleiro[origemX, origemY];
        Peca pecaDestino = tabuleiro[peca.x, peca.y];


        // Verifica se o movimento é válido
        if (!pecaOrigem.validarMovimento(peca.x, peca.y))
        {
            MessageBox.Show("Movimento Inválido!");
            pecaSelecionada = null;
            origemX = -1;
            origemY = -1;
            return;
        }


        if (pecaDestino is CasaVazia) // Se o destino estiver vazio, apenas move a peça
        {
            // Atualiza a matriz
                // Atualiza a matriz
                tabuleiro[origemX, origemY] = new CasaVazia(0, origemX * 50, origemY * 50, "casaVazia.png");
                tabuleiro[peca.x, peca.y] = pecaOrigem;


                // Atualiza as coordenadas da peça movida
                pecaOrigem.x = peca.x;
                pecaOrigem.y = peca.y;


                // Atualiza a posição visualmente
                pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);
        }
        else // Se houver outra peça, troca as posições
        {
            // Se a peça for de outra cor
                if (pecaOrigem.cor != pecaDestino.cor)
                {
                // Remover peça do tabuleiro
                this.Controls.Remove(pecaDestino.pictureBox);


                // Substitui a peça no tabuleiro
                tabuleiro[peca.x, peca.y] = pecaOrigem;
                tabuleiro[origemX, origemY] = new CasaVazia(0, origemX * 50, origemY * 50, "casaVazia.png");


                // Atualiza a posição visualmente
                pecaOrigem.x = peca.x;
                pecaOrigem.y = peca.y;
                pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);

                }  
                else // Se for peça da mesma cor
                {
                    MessageBox.Show("Movimento Inválido!!");
                    pecaSelecionada = null;
                    origemX = -1;
                    origemY = -1;
                    return;
                } 
           
        }


        // Atualiza a interface
        this.Refresh();


        // Reseta os valores para a próxima jogada
        pecaSelecionada = null;
        origemX = -1;
        origemY = -1;
    }
       
}
}
