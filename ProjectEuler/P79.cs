/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/29/2016
 * Time: 9:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of P79.
	/// </summary>
	public class P79
	{
		public static int[] readArray(String filepath){
			string[] lines = System.IO.File.ReadAllLines(@filepath);
			
			int[] result = new int[lines.Length];
			
			int i = 0;
			
			foreach(string line in lines){
				result[i] = Int32.Parse(line);
				i++;
			}
			
			return result;
		}
		
		
		
		public static void solve(){
			String filepath = "C:\\Users\\Spidey7003\\Documents\\SharpDevelop Projects\\ProjectEuler\\ProjectEuler\\p79.txt";
			
			int[] nums = readArray(filepath);
			
			for(int i = 10000000; i < 100000000; i++){
				String s = i.ToString();
				
				int correct = 0;
				
				foreach(int n in nums){
					char[] d = n.ToString().ToCharArray();
					String sPattern = d[0] + ".*" + d[1] + ".*" + d[2];
					if(System.Text.RegularExpressions.Regex.IsMatch(s,sPattern)){
						correct++;
					} else{
						break;
					}
				}
				
				if(correct == nums.Length){
					Console.WriteLine(i);
				}
			}
		}
	}
}
