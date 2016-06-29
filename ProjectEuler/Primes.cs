/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 4:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

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
		
		public static List<long> getPrimesList(long max){
			long[] primes = new long[max+1];
			List<long> result = new List<long>();
			
			primes[0] = -1;
			primes[1] = -1;
				
			for(long i = 2; i <= max; i++){
				primes[i] = i;
			}
			
			for(long i = 2; i <= max; i++){
				if(primes[i] != -1){
					for(long j = i + i; j <= max; j += i){
						primes[j] = -1;
					}
				}
			}
			
			for(long i = 2; i <= max; i++){
				if(primes[i] !=0 && primes[i] != -1){
					result.Add(i);
				}
			}
			
			return result;
		}
	}
}
