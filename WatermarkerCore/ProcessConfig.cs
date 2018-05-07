﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatermarkerCore
{
    /// <summary>
    /// Parameters for a watermaerked processing run
    /// </summary>
    public class ProcessConfig
    {
        string m_pathSrc = string.Empty;
        string m_pathDest = string.Empty;
        string m_prefix = string.Empty;
        string m_body = string.Empty;
        bool m_isMaint = true;

        /// <summary>
        /// The folder containing original images
        /// </summary>
        public string PathSrc { get => m_pathSrc; set => m_pathSrc = value; }

        /// <summary>
        /// The location to save watermarked copies
        /// </summary>
        public string PathDest { get => m_pathDest; set => m_pathDest = value; }

        /// <summary>
        /// The prefix to apply to a watermarked copy's file name
        /// </summary>
        public string Prefix { get => m_prefix; set => m_prefix = value; }

        /// <summary>
        /// Watermark text
        /// </summary>
        public string Body { get => m_body; set => m_body = value; }

        /// <summary>
        /// Maintenance mode flag
        /// Only process files without a watermarked copy if true
        /// </summary>
        public bool IsMaint { get => m_isMaint; set => m_isMaint = value; }
    }
}
