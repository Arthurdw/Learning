module.exports = {
  // purge: [],
  purge: {
    mode: "all",
    enabled: true,
    preserveHtmlElements: false,
    layers: ["base", "components", "utilities"],
    content: ["./dist/**/*.html"],
    options: {
      keyframes: true,
      fontFace: true,
    },
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {
      zIndex: {
        "-1": "-1",
      },
    },

    container: {
      center: true,
    },

    colors: {
      amaranth: {
        // Dark accent - Dark red
        100: "#f7cdd4",
        200: "#f09ba9",
        300: "#e8687f",
        400: "#e13654",
        500: "#d90429",
        600: "#ae0321",
        700: "#820219",
        800: "#570210",
        900: "#2b0108",
      },

      imperial: {
        // Light accent - Light red
        100: "#fcd3d8",
        200: "#f9a7b1",
        300: "#f57b8a",
        400: "#f24f63",
        500: "#ef233c",
        600: "#bf1c30",
        700: "#8f1524",
        800: "#600e18",
        900: "#30070c",
      },

      space: {
        // main item color - Dark gray
        100: "#d5d5d9",
        200: "#aaabb3",
        300: "#80818e",
        400: "#555768",
        500: "#2b2d42",
        600: "#222435",
        700: "#1a1b28",
        800: "#11121a",
        900: "#09090d",
      },

      manatee: {
        // second item color - Light gray
        100: "#e8ebef",
        200: "#d1d6df",
        300: "#bbc2ce",
        400: "#a4adbe",
        500: "#8d99ae",
        600: "#717a8b",
        700: "#555c68",
        800: "#383d46",
        900: "#1c1f23",
      },

      alice: {
        // Background color - Dark white
        100: "#fbfcfd",
        200: "#f8fafb",
        300: "#f4f7f8",
        400: "#f1f5f6",
        500: "#edf2f4",
        600: "#bec2c3",
        700: "#8e9192",
        800: "#5f6162",
        900: "#2f3031",
      },
    },
  },
  variants: {
    extend: {},
  },
  plugins: [require("tailwindcss"), require("autoprefixer")],
};
