#include <stdio.h>
#include<iostream>

using namespace std;

int g(int a, int b){
    if(a==0){
        return b;
    }
    if(b==0){
        return a;
    }
    return g(b, a%b);
    
}
int gcd(int arr[], int n){
    int list = arr[0];
    for(int i = 1; i < n; i++){
        list = g(arr[i], list);
    }
    return list;
}
int main()
{
	int a,num1,num2;
    int arr[] = {8, 16, 12,20};
    int n = sizeof(arr)/ sizeof(arr[0]);
    printf("gcd =%d\n", gcd(arr, n));
    int g = gcd(arr,n);
	for(int j = 0; j<=(n-1); j++){
		for(int k=(j+1) ; k<=(n-1); k++){
			for(int l = 1; l<=(arr[j]); l++){
				if((arr[j] / g) % l == 0 && (arr[k] / g) % l == 0){
				a = l;	
				}
			}
			if(a == 1){
				for(int i = 1; i <= (arr[k]/g); i++){
      		  		if(((arr[j]/g)*i-1) % (arr[k]/g) == 0){
      		  			num1 = i;
      		  			num2 = -(i*arr[j] - 1)/arr[k];
        				printf("u%d= %d\n",j, num1);
        				printf("u%d= %d\n",k, num2 );
					}
			    }
			    break;
			}
		}
		if(a==1){
		break;
		}
	}
    return 0;
    
}


