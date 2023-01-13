using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using System.Net.NetworkInformation;

namespace Chess.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        public List<Piece> pieces = new List<Piece>();
        // Create a 2D int array to represent the chess board
        public int[,] board = new int[8, 8]
                   {
                {0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0}
                   };
        



        private readonly ILogger<IndexModel> _logger;
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 0)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 1)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 2)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 3)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 4)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 5)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 6)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 7)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, KeyValuePair.Create(0, 0)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, KeyValuePair.Create(0, 7)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, KeyValuePair.Create(0, 1)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, KeyValuePair.Create(0, 6)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, KeyValuePair.Create(0, 2)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, KeyValuePair.Create(0, 5)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Queen, KeyValuePair.Create(0, 3)));
            pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.King, KeyValuePair.Create(0, 4)));

            //now for the white pieces
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 0)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 1)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 2)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 3)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 4)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 5)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 6)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 7)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, KeyValuePair.Create(7, 0)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, KeyValuePair.Create(7, 7)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, KeyValuePair.Create(7, 1)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, KeyValuePair.Create(7, 6)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, KeyValuePair.Create(7, 2)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, KeyValuePair.Create(7, 5)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Queen, KeyValuePair.Create(7, 3)));
            pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.King, KeyValuePair.Create(7, 4)));
            





        }





    }

    public class Piece
    {
        public enum PieceColor { White, Black };
        public enum PieceType { Pawn, Knight, Bishop, Rook, Queen, King };

        public PieceColor Color { get; }
        public PieceType Type { get; set; }
        public string PieceImageSource { get; set; }
       
        public KeyValuePair<int, int> chessPiecePosition { get; set; }
        

        
        public Boolean IsCaptured { get; set; }

        public Piece(PieceColor color, PieceType type, KeyValuePair<int, int> position)
        {
            Color = color;
            Type = type;
            chessPiecePosition = position;
            IsCaptured = false;

            // System.Drawing.Image.FromFile("path/to/image.jpg");
            switch (Type)
            {
                case PieceType.Pawn:
                    if (Color == PieceColor.White)
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/4/45/Chess_plt45.svg";
                    }
                    else
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Chess_pdt45.svg";
                    }
                   


                    break;
                case PieceType.Knight:
                    if (Color == PieceColor.White)
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/7/70/Chess_nlt45.svg";
                    }
                    else
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/e/ef/Chess_ndt45.svg";
                    }
                    break;
                case PieceType.Bishop:
                    if (Color == PieceColor.White)
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/b/b1/Chess_blt45.svg";
                    }
                    else
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/9/98/Chess_bdt45.svg";
                    }
                    break;
                case PieceType.Rook:
                    if (Color == PieceColor.White)
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/7/72/Chess_rlt45.svg";
                    }
                    else
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/f/ff/Chess_rdt45.svg";
                    }
                    break;
                case PieceType.Queen:
                    if (color == PieceColor.White)
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/1/15/Chess_qlt45.svg";
                    }
                    else
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/4/47/Chess_qdt45.svg";
                    }
                    break;
                case PieceType.King:
                    if (Color == PieceColor.White)
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/4/42/Chess_klt45.svg";
                    }
                    else
                    {
                        PieceImageSource = "https://upload.wikimedia.org/wikipedia/commons/f/f0/Chess_kdt45.svg";
                    }
                    break;
                default:
                    Console.WriteLine("Invalid PieceType");
                    break;
            }
        }

        public void Move(KeyValuePair<int, int> position)
        {
            chessPiecePosition = position;
        }
    }
}