<template>
  <q-page-container>
    <q-page>
      <q-badge color="secondary" multi-line> Model: "{{ model }}"</q-badge>

      <q-select
        @click="refreshUsers"
        filled
        v-model="test"
        :options="options"
        label="Standard"
        color="teal"
        clearable
        options-selected-class="text-deep-orange"
      >
        <template v-slot:option="scope">
          <q-item v-bind="scope.itemProps">
            <q-item-section avatar>
              <q-icon :name="scope.opt.icon" />
            </q-item-section>
            <q-item-section>
              <q-item-label>{{ scope.opt.label }}</q-item-label>
              <q-item-label caption>{{ scope.opt.description }}</q-item-label>
            </q-item-section>
          </q-item>
        </template>
      </q-select>
      <h6>заплатил(а) за что-то.</h6>

      <q-input
        outlined
        v-model="number"
        type="number"
        prefix="$"
        label="Сумма?"
      >
        <template v-slot:append></template>
      </q-input>

      <div class="q-pa-md">
        <div class="q-gutter-sm">
          <q-radio v-model="typepay" val="line" label="Line" />
          <q-radio v-model="typepay" val="rectangle" label="Rectangle" />
        </div>

        <div class="q-px-sm">
          Your selection is: <strong>{{ shape }}</strong>
        </div>
      </div>

      <q-input outlined v-model="number" type="string" label="причина?">
        <template v-slot:append></template>
      </q-input>

      <!-- дата пикер -->
      <div class="q-pa-md">
        <div class="q-gutter-md row items-start">
          <q-date v-model="date" />
        </div>
      </div>

      <div class="q-pa-md q-gutter-md text-center">
        <div class="q-gutter-md row justify-center">
          <q-btn label="Добавить" color="primary" @click="createEvent" />
          <q-btn label="Отмена" color="grey-8" @click="createEvent" />
        </div>
      </div>
    </q-page>
  </q-page-container>
</template>
<script>
export default {
  name: "AddSplits",
  props: {
    createEvent: {},
    refreshUsers: {},
    model: {},
    options: {},
  },

  data() {
    return {
      date: "",
      typepay: "",
      test: null,
    };
  },
};
</script>
