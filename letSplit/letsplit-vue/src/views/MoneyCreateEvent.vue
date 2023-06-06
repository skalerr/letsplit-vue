<template>
  <q-page padding>
    <q-card class="q-my-md bg-grey-4">
      <q-card-section class="text-h6">Создать ивент</q-card-section>
      <q-card-section>
        <q-card-section class="bg-grey-2">
          <q-input
            v-model="myevent.eventName"
            label="Название ивента"
            outlined
          />
          <q-select
            v-model="myevent.currency"
            :options="myevent.currencies"
            label="Валюта"
            outlined
          />
        </q-card-section>

        <q-card-section class="text-h6">Участники</q-card-section>
        <div
          v-for="(participant, index) in myevent.participants"
          :key="index"
          class="q-my-md"
        >
          <q-card-section class="bg-grey-2">
            <q-item-label>
              {{ index === 0 ? "Вы" : `Участник ${index + 1}` }}
            </q-item-label>
            <q-input
              v-model="participant.name"
              :label="index === 0 ? 'Вы' : 'Имя'"
              outlined
            />
            <q-input
              v-if="index == 0"
              v-model="participant.email"
              label="Почта"
              outlined
            />
          </q-card-section>
        </div>
        <q-btn
          class="bg-grey-2"
          label="Add Participant"
          @click="addParticipant"
        />
      </q-card-section>
      <q-card-actions>
        <q-btn label="Создать событие" color="primary" @click="createEvent" />
      </q-card-actions>
    </q-card>
  </q-page>
</template>
<script>
import { mapActions, mapGetters, mapMutations, mapState } from "vuex";

export default {
  data() {
    return {};
  },
  mounted() {
    console.log(this.myevent);
    // this.myevent = this.myevent.participants;
  },

  computed: {
    ...mapGetters({
      myevent: "getEvent",
    }),

    ...mapState({}),
  },

  methods: {
    ...mapActions(["setEventName", "setCurrency"]),
    ...mapMutations(["ADD_PARTICIPIANT", "SET_EVENT"]),
    addParticipant() {
      const participant = {
        name: "",
        email: "",
        label: "",
        value: "",
      };
      this.ADD_PARTICIPIANT(participant);
    },
    createEvent() {
      this.SET_EVENT(this.myevent);
      console.log(this.myevent);
    },
  },
};
</script>
