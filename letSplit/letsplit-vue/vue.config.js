module.exports = {
  configureWebpack: {
    // output: {
    //   filename: 'main.js'
    // }
  },

  transpileDependencies: [
    'quasar'
  ],

  // линтер по умолчанию true, ворнинг превращает все ошибки в предупреждения из-за чего не падает сборщик отключать по желанию
  lintOnSave: 'warning',

  filenameHashing: false,

  pluginOptions: {
    quasar: {
      importStrategy: 'kebab',
      rtlSupport: false
    }
  }
}
