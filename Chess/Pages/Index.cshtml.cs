using Chess.Pages.model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Drawing;
using System.Net.NetworkInformation;


namespace Chess.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {





       


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
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 0)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 1)));
            // ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 2)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 3)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 4)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 5)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 6)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(1, 7)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, KeyValuePair.Create(0, 0)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Rook, KeyValuePair.Create(0, 7)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, KeyValuePair.Create(0, 1)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Knight, KeyValuePair.Create(0, 6)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, KeyValuePair.Create(0, 2)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Bishop, KeyValuePair.Create(0, 5)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Queen, KeyValuePair.Create(0, 3)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.King, KeyValuePair.Create(0, 4)));


            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 0)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 1)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 2)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 3)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 4)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 5)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 6)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Pawn, KeyValuePair.Create(6, 7)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, KeyValuePair.Create(7, 0)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Rook, KeyValuePair.Create(7, 7)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, KeyValuePair.Create(7, 1)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Knight, KeyValuePair.Create(7, 6)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, KeyValuePair.Create(7, 2)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Bishop, KeyValuePair.Create(7, 5)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.Queen, KeyValuePair.Create(7, 3)));
            //ChessGame.pieces.Add(new Piece(Piece.PieceColor.White, Piece.PieceType.King, KeyValuePair.Create(7, 4)));





            //ChessGame.pieces.First(p => p.chessPiecePosition.Key == 1 && p.chessPiecePosition.Value == 0).Move(KeyValuePair.Create(4, 4));


        }



        public void PieceMove() {

            
            //pieces.First(p => p.chessPiecePosition.Key == 2 && p.chessPiecePosition.Value == 0).Move(KeyValuePair.Create(5, 4));
           


        }
        
        public IActionResult OnPost(string position)
        {
            //first char of position is the row, second char is the column
           
            int row = int.Parse(position[0].ToString());
            int column = int.Parse(position[2].ToString());

            //pieces.Add(new Piece(Piece.PieceColor.Black, Piece.PieceType.Pawn, KeyValuePair.Create(row, column)));
            ChessGame.pieces.RemoveAt(ChessGame.pieces.FindIndex(p => p.chessPiecePosition.Key == row && p.chessPiecePosition.Value == column));

            


            return Page();
        }






    }

   
}