/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/29/2016
 * Time: 10:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of P179.
	/// </summary>
	public class P179
	{
		public static int numDivisors(long n){
			int result = 0;
			for(int i = 1; i <= Math.Sqrt(n); i++){
				if(n % i == 0){
					if(i*i == n){
						result++;
					} else{
						result += 2;
					}
				}
			}
			
			return result;
		}
		
		public static void solve(){
			long max = (long) Math.Pow(10,7)+1;
			int prevDivisors = -1;
			int count = 0;
			
			for(int i = 1; i < max; i++){
				if(i % (max/100) == 0){
					Console.WriteLine(i);
				}
				int divisors = numDivisors(i);
				
				if(divisors == prevDivisors){
					count++;
				}
				
				prevDivisors = divisors;
			}
			
			Console.WriteLine(count);
		}
	}
}
