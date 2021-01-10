#include <metal_stdlib>
using namespace metal;
struct params_t {
  float4x4 mvp;
};
struct vs_in {
  float4 position [[attribute(0)]];
  float4 color [[attribute(1)]];
  float2 uv [[attribute(2)]];
};
struct vs_out {
  float4 pos [[position]];
  float4 color;
  float2 uv;
};
vertex vs_out _main(vs_in in [[stage_in]], constant params_t& params [[buffer(0)]]) {
  vs_out out;
  out.pos = params.mvp * in.position;
  out.color = in.color;
  out.uv = in.uv;
  return out;
}                