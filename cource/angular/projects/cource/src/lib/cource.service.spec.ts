import { TestBed } from '@angular/core/testing';
import { CourceService } from './services/cource.service';
import { RestService } from '@abp/ng.core';

describe('CourceService', () => {
  let service: CourceService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(CourceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
