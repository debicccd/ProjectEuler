﻿/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 10:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	class Program
	{
		public static void Main(string[] args)
		{
			P204 p = new P204((long) Math.Pow(10,9));
			
			p.solve(100);
			
			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}