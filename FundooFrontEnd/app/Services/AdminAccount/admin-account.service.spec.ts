import { TestBed } from '@angular/core/testing';

import { AdminAccountService } from './admin-account.service';

describe('AdminAccountService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdminAccountService = TestBed.get(AdminAccountService);
    expect(service).toBeTruthy();
  });
});
