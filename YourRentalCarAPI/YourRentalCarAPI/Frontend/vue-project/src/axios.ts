import axios from 'axios';
import acsess from './components/acsess.vue'

// axios.defaults.withCredentials = true;
axios.defaults.baseURL = 'https://localhost:7114';
axios.defaults.headers.common['Authorization'] = `Bearer ${acsess.acsessToken}`