
﻿// http://sourceforge.net/p/urgnetwork/wiki/cs_sample_jp/

using System;
using System.Collections.Generic;
using System.Text;

using UnityEngine;

namespace SCIP_library
{
    public class SCIP_Writer
    {
		public static string END
		{
			get{ return "\n"; }
		}

        /// <param name="start">measurement start step</param>
        /// <param name="end">measurement end step</param>
        /// <param name="grouping">grouping step number</param>
        /// <param name="skips">skip scan number</param>
        /// <param name="scans">get scan numbar</param>
        /// <returns>created command</returns>
        public static string MD(int start, int end, int grouping = 1, int skips = 0, int scans = 0)
        {
			return UrgDevice.GetCMDString(UrgDevice.CMD.MD) + start.ToString("D4") + end.ToString("D4") + grouping.ToString("D2") + skips.ToString("D1") + scans.ToString("D2") + END;
        }
		public static string ME(int start, int end, int grouping = 1, int skips = 0, int scans = 0)
		{
			return UrgDevice.GetCMDString(UrgDevice.CMD.ME) + start.ToString("D4") + end.ToString("D4") + grouping.ToString("D2") + skips.ToString("D1") + scans.ToString("D2") + END;
		}

		public static string BM()
		{
			return UrgDevice.GetCMDString(UrgDevice.CMD.BM) + END;
		}
		public static string GD(int start, int end, int grouping = 1)
		{
			return UrgDevice.GetCMDString(UrgDevice.CMD.GD) + start.ToString("D4") + end.ToString("D4") + grouping.ToString("D2") + END;
		}
		
		public static string VV()
        {
			return UrgDevice.CMD.VV.ToString() + END;