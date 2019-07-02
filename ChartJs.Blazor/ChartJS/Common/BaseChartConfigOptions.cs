﻿using ChartJs.Blazor.ChartJS.Common.Legends;

namespace ChartJs.Blazor.ChartJS.Common
{
    public class BaseChartConfigOptions
    {
        public OptionsTitle Title { get; set; }

        /// <summary>
        /// Resizes the chart canvas when its container does.
        /// <para>See important note: https://www.chartjs.org/docs/latest/general/responsive.html#important-note </para>
        /// </summary>
        public bool Responsive { get; set; } = true;

        /// <summary>
        /// Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas). 
        /// <para>Note that this option is ignored if the height is explicitly defined either as attribute (of the canvas) or via the style.</para>
        /// </summary>
        public double AspectRatio { get; set; } = 2;

        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing.
        /// </summary>
        public bool MaintainAspectRatio { get; set; } = true;

        /// <summary>
        /// Duration in milliseconds it takes to animate to new size after a resize event.
        /// </summary>
        public int ResponsiveAnimationDuration { get; set; }

        public Legend Legend { get; set; } = new Legend();
    }
}