print("adinizi giriniz: ")
ad = input()
adu = len(ad)

if adu > 10:
    print("adiniz oldukca uzun")
elif adu < 5:
    print("adiniz sasirtici derecede kisa")
else:
    print("adiniz tam olmasi gereken uzunlukta")
