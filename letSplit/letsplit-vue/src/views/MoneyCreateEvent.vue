<template>
  <q-page padding>
    <q-card class="q-my-md bg-grey-4">
      <q-card-section class="text-h6">Создать ивент</q-card-section>
      <q-card-section>
        <q-card-section class="bg-grey-2">
          <q-input v-model="eventName" label="Название ивента" outlined />
          <q-select
            v-model="currency"
            :options="currencies"
            label="Валюта"
            outlined
          />
        </q-card-section>

        <q-card-section class="text-h6">Участники</q-card-section>
        <div
          v-for="(participant, index) in participants"
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
export default {
  data() {
    return {
      eventName: "",
      currency: "",
      currencies: [
        "RUB",
        "USD",
        "EUR",
        "JPY",
        "GBP",
        "AUD",
        "CAD",
        "CHF",
        "CNY",
        "HKD",
        "NZD",
      ],

      participants: [
        {
          name: "",
          email: "",
          label: "",
          value: "",
        },
        {
          name: "",
          email: "",
          label: "",
          value: "",
        },
      ],
      options: [
        // {
        //   label: "Google",
        //   value: "Google",
        //   description: "Search engine",
        //   icon: "mail",
        // },
      ],
    };
  },

  methods: {
    addParticipant() {
      this.participants.push({
        name: "",
        email: "",
      });
    },
    createEvent() {
      // Send event data to server using axios or any other HTTP client library
      console.log({
        eventName: this.eventName,
        currency: this.currency,
        participants: this.participants,
      });
    },
  },
};
</script>
