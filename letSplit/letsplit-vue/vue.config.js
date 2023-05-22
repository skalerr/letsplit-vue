module.exports = {
  configureWebpack: {
    // output: {
    //   filename: 'main.js'
    // }
  },
  transpileDependencies: true,
  lintOnSave: 'warning', // линтер по умолчанию true, ворнинг превращает все ошибки в предупреждения из-за чего не падает сборщик отключать по желанию
  filenameHashing: false,
}