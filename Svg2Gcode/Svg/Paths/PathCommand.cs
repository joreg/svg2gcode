﻿using Svg2Gcode.Spatial;
using Utils.Spatial;

namespace Svg2Gcode.Svg.Paths
{
    public abstract record PathCommand(bool IsRelative = false)
    {
        public abstract IEnumerable<(bool, Path2D)> GetPaths(Vector2D pathStart, Vector2D commandStart);
    }
}