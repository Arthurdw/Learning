module.exports = {
  purge: {
    mode: 'all',
    enabled: true,
    preserveHtmlElements: false,
    layers: ['base', 'components', 'utilities'],
    content: ['./dist/**/*.html'],
    options: {
      keyframes: true,
      fontFace: true,
    },
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
    container: {
      center: true,
      padding: "2rem",
    },
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
