/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/29/2016
 * Time: 10:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Description of P204.
	/// </summary>
	public class P204
	{
		List<long> primes;
		long max;
		
		public P204(long max){
			this.max = max;
			primes = Primes.getPrimesList((long) (Math.Sqrt(max)+1));
		}
		
		public bool isHamming(long num, long n){
			bool result = true;
			
			while(num % 2 == 0){
				num /= 2;
			}
			
			foreach(long prime in primes){
				if(num == 1){
					break;
				}
				
				if(prime > n){
					result = false;
					break;
				}
				
				while(num % prime == 0){
					num /= prime;
				}
			}
			
			return result;
		}
		
		public void solve(int n){
			int count = 1;
			for(int i = 2; i <= max; i++){
				if(i % (max/100) == 0){
					Console.WriteLine(i/(max/100));
				}
				
				if(isHamming(i, n)){
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}
}
