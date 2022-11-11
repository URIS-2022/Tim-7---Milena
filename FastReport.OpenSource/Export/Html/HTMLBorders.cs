using System;
using System.Collections.Generic;
using System.Text;

namespace FastReport.Export.Html
{
    /// <summary>
    /// Class with fields required for border
    /// </summary>
    public class HtmlBorders
    {
        /// <summary>
        /// Left border
        /// </summary>
        public float Left { get; set; }
        /// <summary>
        /// Top border
        /// </summary>
        public float Top { get; set; }
        /// <summary>
        /// Border height
        /// </summary>
        public float Width { get; set; }
        /// <summary>
        /// Border Width
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Constructor that takes 4 arg
        /// </summary>
        public HtmlBorders(float left, float top, float width, float height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }

    }
}
