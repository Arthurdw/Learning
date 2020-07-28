struct Rectangle {
    width: u32,
    height: u32,
}

impl Rectangle {
    fn is_square(&self) -> bool {
        self.width == self.height
    }
}

fn main() {}

fn give_two() -> u8 {
    2
}

#[cfg(test)]
mod arthur_tests {
    #[test]
    #[should_panic]
    fn test_basic() {
        assert_eq!(1, 1);
        panic!("Oh :0");
    }

    #[test]
    // #[ignore]
    fn test_equals() {
        assert_eq!(super::give_two(), 1 + 1);
        assert_ne!(super::give_two(), 1 + 2);
    }

    #[test]
    // #[should_panic]
    fn test_struct() {
        let r = super::Rectangle {
            width: 50,
            height: 50,
        };

        assert!(r.is_square());
    }
}
