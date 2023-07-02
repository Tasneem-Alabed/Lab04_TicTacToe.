using Lab04_TicTacToe.Classes;

namespace TestProject1

    {
        public class UnitTest1
        {
            [Fact]
            public void Test()
            {
              
                Player playerOne = new Player();
                playerOne.Name = "Player1";
                playerOne.Marker = "x";
                playerOne.IsTurn = true;

                Player playerTwo = new Player();
                playerTwo.Name = "Player2";
                playerTwo.Marker = "o";
                Game game = new Game(playerOne, playerTwo);
                game.Board.GameBoard[0, 0] = "x";
                game.Board.GameBoard[0, 1] = "x";
                game.Board.GameBoard[0, 2] = "x";
               
                bool hasWinner = game.CheckForWinner(game.Board);
             
                Assert.Equal(hasWinner, true);

            }
            [Fact]
            public void Test2()
            {
              
                Player playerOne = new Player();
                playerOne.Name = "Player1";
                playerOne.Marker = "x";
                playerOne.IsTurn = true;
                Player playerTwo = new Player();
                playerTwo.Name = "Player2";
                playerTwo.Marker = "o";
                Game game = new Game(playerOne, playerTwo);
                game.Board.GameBoard[1, 0] = "o";
                game.Board.GameBoard[1, 1] = "o";
                game.Board.GameBoard[1, 2] = "x";
              
                bool hasWinner = game.CheckForWinner(game.Board);
              
                Assert.Equal(hasWinner, false);

            }
            [Fact]
            public void Test3()
            {
               
                Player playerOne = new Player();
                playerOne.Name = "Player1";
                playerOne.Marker = "x";
                playerOne.IsTurn = true;
                Player playerTwo = new Player();
                playerTwo.Name = "Player2";
                playerTwo.Marker = "o";
                Game game = new Game(playerOne, playerTwo);

                game.SwitchPlayer();
          
                bool change = playerOne.IsTurn == false && playerTwo.IsTurn == true;
                ;
              
                Assert.Equal(change, true);

            }
           
            

        }

    }
