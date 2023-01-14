namespace Chess.Pages.model
{
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
