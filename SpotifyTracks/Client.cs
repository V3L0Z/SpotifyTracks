using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SpotifyTracks
{
    public class Client
    {
        public HttpClient PassToken()
        {
            string token = "BQBQCsLkym20j4Xy7-NfZ-V1q6T33goHeAODIgTnvIThJiplQVyyiHrQLSf80fBfeBu4axnYcDnmsbh38ybqe24iuwNsZXT4YNQ19apsfCKaJiPXgFnmrCSAXUFDaocQ6KM9C3Plkdpkb5RCjFBxnXI0MyYRW1FmpVyOCbesxuxWaXEzSOGINfDRAGzLcXaCFxbuX5HRw1sb7w7mf9oc8sgaBnVeJYkRDx-cznMgaeqq71NZ0ye5AKo8ZxBCoqg9kz0APFc0UVbGTKmpOg";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return client;
        }
        
    }
}
