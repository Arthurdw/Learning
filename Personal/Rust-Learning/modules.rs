mod arthur {
    fn eat() {
        println!("Nom nom, very nommy");
    }

    pub fn say_hello() {
        println!("Hello there! :wave:");
        eat();
    }

    pub mod fluids {
        pub enum fluids {
            water,
            cola,
            vodka,
            rum
        }

        pub fn drink(fluid: fluids) {
            match fluid {
                fluids::water => println!("Drinking some healthy water!"),
                fluids::cola => println!("Started drinking some coke with a slice of lemon!"),
                fluids::vodka => println!("Drinking vodka with the boys!"),
                fluids::rum => println!("Hmm, this tastes... very good!"),
            }
        }
    }

}

fn main() {
    arthur::say_hello();
    arthur::fluids::drink(arthur::fluids::fluids::cola)
}
