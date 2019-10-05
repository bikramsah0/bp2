import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ListAndSearchFilterDto } from '../../dtos/list-and-search/list-and-search-filter-dto.dto';
import { DataLoader } from '../../entities/list-and-search/list-and-search-data-loader.entity';
import { ListAndSearchFilter } from '../../entities/list-and-search/list-and-search-filter.entity';
import { ListAndSearchRequest } from '../../entities/list-and-search/list-and-search-request.entity';
import { ApiPaginatedCollection } from '../common/models';
// import { TradePartialDisplayView } from '../../models/trade-partial-display-view';
import { TradingService } from '../http-services/trading.service';
import { SectionSearchResult } from './../../dtos/section-search-result';

@Injectable()
export class TradeDataLoader implements DataLoader {
    constructor(private tradingService: TradingService) { }

    getData(filters: ListAndSearchFilter[],
        dataVersionId?: number,
        offset?: number,
        limit?: number): Observable<ApiPaginatedCollection<any>> {

        const filtersForColumns: ListAndSearchFilterDto[] = filters.map((filter) => {
            return new ListAndSearchFilterDto(filter);
        });

        const request: ListAndSearchRequest = {
            clauses: { clauses: filtersForColumns },
            offset,
            limit,
            dataVersionId,
        };

        const list = this.tradingService.search(request)
            .pipe(
                map((data) => {
                    return data;
                }),
            );

        return list;
    }
}