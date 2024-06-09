import axios from 'axios';
import BASE_ENDPOINTS from '../data/constants/BaseEndpoints';

const QualificationsService = {

    getQualifications: async () => {
        return await axios.get(BASE_ENDPOINTS.QUALIFICATIONS);
    }

}

export default QualificationsService;