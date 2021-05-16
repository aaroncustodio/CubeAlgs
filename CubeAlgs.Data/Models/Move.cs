namespace CubeAlgs.Data.Models
{
    public class Move
    {
        public Move(string move)
        {
            Notation = move;
        }

        public string Notation { get; set; }
        public bool IsPrime { get; set; }
        public bool IsSliceTurn { get; set; }
        public bool IsDoubleLayer { get; set; }
        public bool IsRotation { get; set; }
    }
}
