#include <stdio.h>
#include <string.h>

int main() {
  printf("adinizi girin: ");
  char ad[20];
  scanf("%s", ad);
  int adu = strlen(ad);

  if (adu > 10) {
    printf("adiniz cok uzun");
  } else if (adu < 5) {
    printf("adiniz cok kisa");
  } else {
    printf("adiniz tam olmasi gerektigi gibi\n");
  }
  return 0;
}
