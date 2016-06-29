/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 10:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of Problem82.
	/// </summary>
	public class Problem82
	{
		public static int[,] readArray(String filepath){
			string[] lines = System.IO.File.ReadAllLines(@filepath);
			
			int[,] result = new int[lines.Length, lines.Length];
			
			int i = 0;
			
			foreach(string line in lines){
				string[] nums = line.Split(",".ToCharArray());
				int j = 0;
				foreach(string num in nums){
					result[i,j] = Int32.Parse(num);
					j++;
				}
				i++;
			}
			
			return result;
		}
		
		public static void solve(){
			String filepath = "C:\\Users\\Spidey7003\\Documents\\SharpDevelop Projects\\ProjectEuler\\ProjectEuler\\p82_small.txt";
			
			int[,] numGrid = readArray(filepath);
			int[,] pathGrid = new int[numGrid.Length,numGrid.Length];
			
//			for(int i = numGrid.Length - 1; i > 0; i--){
//				for(int j = 0; j < numGrid.Length; j++){
//					if(j = 0){
//						pathGrid[i][j] = Math.Min(numGrid[i-1][j], numGrid[i][j+1]) + numGrid[i][j];
//					} else if(j = numGrid.Length - 1){
//						pathGrid[i][j] = Math.Min(numGrid[i-1][j], numGrid[i][j-1]) + numGrid[i][j];
//					} else{
//						//pathGrid
//					}
//				}
//			}
		}
		
	}
}
