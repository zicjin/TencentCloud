/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tmt.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tmt.V20180321.Models;

   public class TmtClient : AbstractClient{

       private const string endpoint = "tmt.tencentcloudapi.com";
       private const string version = "2018-03-21";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TmtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TmtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 提供中文到英文、英文到中文两种语言的图片翻译服务，可自动识别图片中的文本内容并翻译成目标语言
        /// </summary>
        /// <param name="req">参考<see cref="ImageTranslateRequest"/></param>
        /// <returns>参考<see cref="ImageTranslateResponse"/>实例</returns>
        public async Task<ImageTranslateResponse> ImageTranslate(ImageTranslateRequest req)
        {
             JsonResponseModel<ImageTranslateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageTranslate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageTranslateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可自动识别文本内容的语言种类，轻量高效，无需额外实现判断方式，使面向客户的服务体验更佳。
        /// </summary>
        /// <param name="req">参考<see cref="LanguageDetectRequest"/></param>
        /// <returns>参考<see cref="LanguageDetectResponse"/>实例</returns>
        public async Task<LanguageDetectResponse> LanguageDetect(LanguageDetectRequest req)
        {
             JsonResponseModel<LanguageDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LanguageDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LanguageDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口提供音频内文字识别 + 翻译功能，目前开放中到英的语音翻译服务。
        /// 待识别和翻译的音频文件可以是 pcm、mp3、amr和speex 格式，音频内语音清晰，采用流式传输和翻译的方式。
        /// </summary>
        /// <param name="req">参考<see cref="SpeechTranslateRequest"/></param>
        /// <returns>参考<see cref="SpeechTranslateResponse"/>实例</returns>
        public async Task<SpeechTranslateResponse> SpeechTranslate(SpeechTranslateRequest req)
        {
             JsonResponseModel<SpeechTranslateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SpeechTranslate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SpeechTranslateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供中文到英文、英文到中文的等多种语言的文本内容翻译服务， 经过大数据语料库、多种解码算法、翻译引擎深度优化，在新闻文章、生活口语等不同语言场景中都有深厚积累，翻译结果专业评价处于行业顶级水平。
        /// </summary>
        /// <param name="req">参考<see cref="TextTranslateRequest"/></param>
        /// <returns>参考<see cref="TextTranslateResponse"/>实例</returns>
        public async Task<TextTranslateResponse> TextTranslate(TextTranslateRequest req)
        {
             JsonResponseModel<TextTranslateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextTranslate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextTranslateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
