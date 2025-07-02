using Godot;
using System;

public partial class Player : CharacterBody2D
{

    [Export]
    public int speed { get; set; }

    public override void _Ready()
    {
        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);

        GetInput();
    }

    public void GetInput()
    {
        Vector2 inputDirection = Input.GetVector("A", "D", "W", "S");
        Velocity = inputDirection.Normalized() * speed;

        MoveAndSlide();
    }
}
