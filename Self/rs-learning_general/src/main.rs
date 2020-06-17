#![allow(unused_variables)]
#![allow(unused_parens)]
fn main() {
    // Our Hello World!
    println!("Hello, World");

    // Basic console log commands:
    let a = 7;
    let b = 1;
    println!("a is {}, b is {}", a, b);
    println!("a is {1}, b is {0}", b, a);
    println!("a is {val_x}, b is {val_y}", val_x = a, val_y = b);
    println!("debug {:?}", (a, b));

    // Mutable objects:
    let mut c = 5;
    println!("c is {}", c);
    c = 6;
    println!("c is {}", c);

    // Shadow objects:
    let d = 5;
    let d = d + 1;
    let d = d * 2;
    println!("d is {}", d);

    // Advantages of shadowing:
    let e = "ABC";
    let e = e.len();
    println!("e is {}", e);

    // Constants:
    const F: u32 = 1920;
    const G: f32 = 3.141592;
    println!("f is {}, g is {}", F, G);

    // Types:
    let h: u128 = 0xFAFBFCFD_FEF1F2F3_F4F5F6F7_F8F9FAFB;
    let i: i64 = 123456;
    let j = 2.0; // f64
    let k: f32 = 3.0;
    println!("h is {}, i is {}, j is {}, k is {}", h, i, j, k);

    let l = 'Z';
    let m = 'ℤ';
    let n = '👍';
    let o = false;
    println!("l is {}, m is {}, n is {}, o is {}", l, m, n, o);

    // Strings:
    let p = "Hello, World";
    println!("p length: {}chars, is empty: {}", p.len(), p.is_empty());
    println!("p bytes: {:?}", p.as_bytes());

    let mut q = String::from("Hello ");
    q.push("W".parse().unwrap());
    q.push_str("orld!");
    println!("q is {}", q);
    q.insert(5, ',');
    println!("q is {}", q);

    // Tuples:
    let r: (i32, f64, u8, f32) = (500, 6.4, 1, 29.29);
    let s = (1500, 3.4);
    let (t, u, v, w) = r;

    println!("t is {}, u is {}, v is {}, w is {}", t, u, v, w);
    let x = r.0;
    let y = r.1;
    let z = r.2;
    let aa = r.3;
    println!("x is {}, y is {}, z is {}, aa is {}", x, y, z, aa);

    // Arrays:
    let ab = [1, 2, 3, 4, 5];
    let ac: [u16; 5] = [1, 2, 3, 4, 5];
    let ad = [0; 5];  // Array of 5 long all 0's
    println!("ab is {:?}, ac is {:?}, c is {:?}", ab, ac, ad);
    let ae = ["January", "February", "March", "And the rest"];
    let af = ab[0];
    let ag = ae[1];
    println!("af is {}, ag is {}", af, ag);

    // Expressions and statements:
    let ah = 3 + 7;
    let ai = (3 + 7);
    let aj = {3 + 7};
    let ak = {
        let mut x = 3;
        x = x *2;
        x + 1 //  Returns this
    };
    println!("ah is {}, ai is {}, aj is {}, ak is {}", ah, ai, aj, ak);

    // Functions:
    let al = am();
    fn am() -> i32 { 5 };
    println!("al is {}", al);

    let an = ao(am());
    fn ao(x: i32) -> i32 { x + 1 }
    println!("an is {}", an);

    // If statements:
    let ap = aq(10);
    fn aq(x: i32) -> bool {
        if (x & 1) == 0 { false }
        else { true }
    }
    println!("ap is {}", ap);

    // Casting:
    let ar = at((1, 2, 3));
    fn at(t: (u8, u16, u32)) -> (f32, f64) {
        let x:f32 = t.0 as f32 + t.1 as f32;
        let y:f64 = t.2 as f64;
        (x, y)
    }
    println!("ar is {:?}", ar);

    // Matching: (switch statement)
    let au = av(5);
    fn av(x: u64) -> u64 {
        match x {
            0 => 1,
            1 => 1,
            _ => av(x - 1) * x,
        }
    }
    println!("au is {}", au);

    // Loops:
    let mut aw = 0;
    let ax = loop {
        aw += 1;
        if aw == 10 {
            break aw * 2
        }
    };
    println!("aw is {}", aw);

    let mut ay = 0;
    while ay != 10 {
      ay += 1
    };
    println!("ay is {}", ay);

    let az = [1, 2, 3, 4];
    for (idx, numb) in az.iter().enumerate() {
        println!("az.{} is {}", idx, numb);
    }

    for numb in 1..4 { // Range which includes 1, 2, 3
        println!("{}", numb);
    }
}