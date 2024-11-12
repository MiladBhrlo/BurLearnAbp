import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44358/',
  redirectUri: baseUrl,
  clientId: 'BurLearn_App',
  responseType: 'code',
  scope: 'offline_access BurLearn',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BurLearn',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44358',
      rootNamespace: 'BurLearn',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
