using System;
using System.Collections.Generic;
using Raylib_cs;

namespace C__Projects
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;
        Player _player = new Player();
        Platform _platformGround = new Platform(50,500);
        Platform _platform1 = new Platform(470, 400);
        Platform _platform2 = new Platform(175, 450);
        Platform _platform3 = new Platform(300, 400);

        Platform _platform4 = new Platform(600, 300);

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();
        Point _gravityVelocity = new Point(0,2);
        PhysicsService _groundCollision = new PhysicsService();
        ScoreBoard _scoreboard = new ScoreBoard();
        DeathScreen _died = new DeathScreen();
        WinScreen _win = new WinScreen();
        EndGoal _end = new EndGoal(715, 150);

        Tutorial _tutorialText = new Tutorial(200, 100);


        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

                if (_inputService.IsWindowClosing())
                {
                    _keepPlaying = false;
                }
            }
            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "2D-Platformer", Constants.FRAME_RATE);

        }

        /// <summary>
        /// Gets any input needed from the user.
        /// </summary>
        private void GetInputs()
        {

            if (_inputService.IsLeftPressed() && !_inputService.IsSpacePressed())
            {
                _player.SetVelocity(_inputService.GetDirection());
                _player.Move();
                
            }
            else if (_inputService.IsRightPressed() && !_inputService.IsSpacePressed())
            {
                _player.SetVelocity(_inputService.GetDirection());
                _player.Move();
                
            }
            else if (_inputService.IsSpacePressed() && _groundCollision.IsCollision(_player,_platformGround) 
                || _groundCollision.IsCollision(_player,_platform1) 
                || _groundCollision.IsCollision(_player,_platform2) 
                || _groundCollision.IsCollision(_player,_platform3)
                || _groundCollision.IsCollision(_player,_platform4))
            {              
        
                _player.SetVelocity(_inputService.GetDirection());
                _player.Move();
            }
        
        }
        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            
            if(!_groundCollision.IsCollision(_player,_platformGround) 
                && !_groundCollision.IsCollision(_player,_platform1) 
                && !_groundCollision.IsCollision(_player,_platform2) 
                && !_groundCollision.IsCollision(_player,_platform3)
                && !_groundCollision.IsCollision(_player,_platform4)
                && !_groundCollision.IsCollision(_player,_end))
            {
                _player.SetVelocity(_gravityVelocity);
                _player.Move();
            }
            if(_player.IsOffScreen())
            {
                int points = _scoreboard.GetLives();
                _scoreboard.RemovePoints(1);

            }
            if(_scoreboard.GetLives() <= 0)
            {
                _outputService.DrawActor(_died);
                _keepPlaying = false;
            }
            if(_groundCollision.IsCollision(_player, _end))
            {
                _outputService.DrawActor(_win);
            }
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        {
            _outputService.StartDrawing();
            _outputService.DrawActor(_scoreboard);
            _outputService.DrawActor(_tutorialText);
            _outputService.DrawActor(_player);
            _outputService.DrawActor(_platformGround);
            _outputService.DrawActor(_platform1);
            _outputService.DrawActor(_platform2);
            _outputService.DrawActor(_platform3);
            _outputService.DrawActor(_platform4);
            _outputService.DrawActor(_end);
            _outputService.EndDrawing();
            
        }



    }

}