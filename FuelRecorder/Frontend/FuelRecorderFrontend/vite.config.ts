import { fileURLToPath, URL } from 'node:url'

import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
import vueJsx from '@vitejs/plugin-vue-jsx'
import vueDevTools from 'vite-plugin-vue-devtools'

// https://vite.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    vueJsx(),
    vueDevTools(),
  ],
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url))
    },
  },
  server: {
    proxy: {
      '/FuelRecorder': {
        target: 'https://localhost:7213',
        changeOrigin: true,
        secure: false, // Brukes dersom du har selvsignerte sertifikater i utvikling
      },
      '/FuelRecorder/': {
        target: 'https://localhost:7213',
        changeOrigin: true,
        secure: false, // Brukes dersom du har selvsignerte sertifikater i utvikling
      },
      '/login': {
        target: 'https://localhost:7213/Login',
        changeOrigin: true,
        secure: false,
      }
    },
  }
})
