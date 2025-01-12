/* "Barrel" of Http Interceptors */
import { HTTP_INTERCEPTORS } from '@angular/common/http';

import { AuthInterceptor } from './auth-interceptor';
import { DateInterceptor } from './date-interceptor';
//import { ContextInterceptor } from './context-interceptor';

/** Http interceptor providers in outside-in order */
export const httpInterceptorProviders = [
	{ provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true },
	{ provide: HTTP_INTERCEPTORS, useClass: DateInterceptor, multi: true }
	//{ provide: HTTP_INTERCEPTORS, useClass: ContextInterceptor, multi: true }
];
