using System.Numerics;
using Veldrid;
using Veldrid.Sdl2;
using Veldrid.StartupUtilities;

namespace Veldrid_Study
{
    public struct VertexPositionColor
    {
        public Vector2 Position;
        public RgbaFloat Color;

        public VertexPositionColor(Vector2 pos, RgbaFloat color)
        {
            Position = pos;
            Color = color;
        }

        public const uint SizeInBytes = 24;
    }
}
