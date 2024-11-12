import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Cource',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44301/',
    redirectUri: baseUrl,
    clientId: 'Cource_App',
    responseType: 'code',
    scope: 'offline_access Cource',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44301',
      rootNamespace: 'Cource',
    },
    Cource: {
      url: 'https://localhost:44300',
      rootNamespace: 'Cource',
    },
  },
} as Environment;
