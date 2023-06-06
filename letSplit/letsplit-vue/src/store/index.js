import { createStore } from "vuex";
import axios from "axios";

export default createStore({
  state: {
    myEvent: [],
  },
  getters: {
    getEvent(state) {
      return state.myevent;
    },
  },
  mutations: {
    ADD_PARTICIPIANT(state, payload) {
      state.myevent.participants.push({
        name: payload.name,
        email: payload.email,
        label: payload.name,
        value: payload.name,
      });
    },
    SET_EVENT(state, event) {
      state.myevent = event;
    },
    SET_CURRENCY(state, currency) {
      state.currency = currency;
    },
  },

  actions: {
    
    async getEvents({ commit }) {
      let event = await axios.get("http://localhost:3000/events").then((response) => {
        console.log(response.data);
      }).catch((error) => {
        console.error(error);
      });
      commit("SET_EVENT", event);
      
    },

    setEventName({ commit }, eventName) {
      commit("SET_EVENT_NAME", eventName);
    },
    setCurrency({ commit }, currency) {
      commit("SET_CURRENCY", currency);
    },
    // Добавьте другие действия, если необходимо
  },

  modules: {},
});
