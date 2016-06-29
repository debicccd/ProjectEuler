/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 4:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Primes
	{
		public static int[] getPrimes(int max){
			int[] primes = new int[max+1];
			
			primes[0] = -1;
			primes[1] = -1;
				
			for(int i = 2; i <= max; i++){
				primes[i] = i;
			}
			
			for(int i = 2; i <= max; i++){
				if(primes[i] != -1){
					for(int j = i + i; j <= max; j += i){
						primes[j] = -1;
					}
				}
			}
			
			return primes;
		}
	}
}
