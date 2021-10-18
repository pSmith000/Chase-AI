using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;
using Raylib_cs;


namespace MathForGames
{
    class Enemy : Actor
    {
        private float _speed;
        private Vector2 _velocity;
        private Player _player;

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Enemy(char icon, float x, float y, float speed, Player player, Color color, string name = "Enemy")
            : base(icon, x, y, color, name)
        {
            _speed = speed;
            _player = player;
        }

        public override void Update(float deltaTime)
        {
            Vector2 moveDirection = _player.Position - Position;

            Velocity = -moveDirection.Normalized * Speed * deltaTime;

            Position += Velocity;

            base.Update(deltaTime);
        }
    }
}
