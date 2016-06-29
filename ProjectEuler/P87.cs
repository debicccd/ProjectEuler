/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 4:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of P87.
	/// </summary>
	public class P87
	{
		public static int MAX = 50000000;
		public static int squaresMax = 1 + ((int) Math.Pow(MAX, 1.0/2));
		public static int cubesMax = 1 + ((int) Math.Pow(MAX, 1.0/3));
		public static int fourthsMax = 1 + ((int) Math.Pow(MAX, 1.0/4));
			
			
		public static void solve(){
			
			//Console.WriteLine(squaresMax + ":" + cubesMax + ":" + fourthsMax);
			int count = 0;
			int[] primes = Primes.getPrimes(squaresMax);
			int[] nums = new int[MAX];
			
			int[] squares = new int[squaresMax];
			int[] cubes = new int[cubesMax];
			int[] fourths = new int[fourthsMax];
			
			for(int i = 0; i < primes.Length; i++){
				if(primes[i] != -1 && primes[i] != 0){
					int num = primes[i];
					
					if(i < squaresMax){
						squares[i] = num * num;
					}
					
					if(i < cubesMax){
						cubes[i] = num * num * num;
					}
					
					if(i < fourthsMax){
						fourths[i] = num * num * num * num;
					}
				}
			}
			
			foreach(int s in squares){
				if(s == 0)
					continue;
				
				foreach(int c in cubes){
					if(c == 0)
						continue;
					
					foreach(int f in fourths){
						if(f == 0)
							continue;
						
						if(s + c + f < MAX){
							if(nums[s + c + f] == 0){
								count++;
								nums[s + c + f] = -1;
							}
						}
						
					}
				}
				
			}
			
			Console.WriteLine(count);
			
//			for(int i = 0; i < primes.Length; i++){
//				if(primes[i] == -1){
//					continue;
//				}
//				Console.Write(i + "   ");
//				if(i < squaresMax){
//					Console.Write(squares[i] + "   ");
//				}
//					
//				if(i < cubesMax){
//					Console.Write(cubes[i] + "   ");
//				}
//					
//				if(i < fourthsMax){
//					Console.Write(fourths[i] + "   ");
//				}
//				
//				Console.WriteLine();
//			}
		}
	}
}
