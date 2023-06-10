import { createStore } from "vuex";
import axios from "axios";
import settings from "@/settings.js";
export default createStore({
  state: {
    myEvents: [
    ],
  },
  getters: {
    getEvent(state) {
      return state.myEvents[0];
    },
  },
  mutations: {
    // ADD_PARTICIPIANT(state, payload) {
    //   state.myEvents.participants.push({
    //     name: payload.name,
    //     email: payload.email,
    //     label: payload.name,
    //     value: payload.name,
    //   });
    // },
    SET_EVENT(state, event) {
      state.myEvents = event;
    },
    // SET_CURRENCY(state, currency) {
    //   state.currency = currency;
    // },
  },
  actions: {
    async getAllEvents({commit}) {
      let resp;
      await axios
        .get(`${settings.apiUrl}/Money/GetEvents`)
        .then((response) => {
          commit("SET_EVENT", response.data);
          resp = response.data;
        })
        .catch((error) => {
          resp = error;
        });
      return resp;
    },
    // setEventName({ commit }, eventName) {
    //   commit("SET_EVENT_NAME", eventName);
    // },
    // setCurrency({ commit }, currency) {
    //   commit("SET_CURRENCY", currency);
    // },
    // Добавьте другие действия, если необходимо
  },
  modules: {},
});
