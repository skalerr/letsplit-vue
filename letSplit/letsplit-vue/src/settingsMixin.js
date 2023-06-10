import settings from './settings';

const settingsMixin = {
    beforeCreate() {
        this.settings = settings;
    }
};
export default settingsMixin;