use std::io;
fn main() {
    println!("adinizi girin: ");
    let mut ad = String::new();

    io::stdin().read_line(&mut ad).expect("read_line sirasinda hata olustu");

    let adu = ad.len();

    if adu > 10{
        println!("adiniz cok uzun!!!");
    }
    else if adu < 5{
        println!("adiniz cok kisa");
    }
    else{
        println!("adiniz tam olmasi gerektigi gibi");
    }
}
